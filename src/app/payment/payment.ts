import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
  SimpleChanges,
} from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { PaymentService } from '../services/payment';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { finalize } from 'rxjs';

@Component({
  selector: 'app-payment',
  imports: [ReactiveFormsModule, NgxSpinnerModule],
  templateUrl: './payment.html',
  styleUrl: './payment.scss',
})
export class Payment implements OnInit, OnChanges {
  form!: FormGroup;
  submitted: boolean = false;
  @Input() card: any = {};
  @Output() onSubmit = new EventEmitter();
  mode: string = 'add';
  constructor(
    private fb: FormBuilder,
    private service: PaymentService,
    private spinner: NgxSpinnerService,
  ) {}
  ngOnInit(): void {
    this.initForm();
  }
  ngOnChanges(changes: SimpleChanges): void {
    if (changes['card'] && this.form) {
      this.form.patchValue({
        id: this.card?.id ?? '',
        cardName: this.card?.cardName ?? '',
        cardNumber: this.card?.cardNumber ?? '',
        expiredDate: this.card?.expiredDate ?? '',
        privacyNumber: this.card?.privacyNumber ?? '',
      });
      this.mode = 'edit';
    }
  }
  get f() {
    return this.form.controls;
  }
  initForm() {
    this.form = this.fb.group({
      cardName: ['', Validators.required],
      cardNumber: ['', [Validators.maxLength(16), Validators.required]],
      expiredDate: ['', [Validators.maxLength(5), Validators.required]],
      privacyNumber: ['', [Validators.maxLength(3), Validators.required]],
    });
  }
  addNewCard(formPayload: any) {
    this.spinner.show();
    this.service
      .addCard(formPayload)
      .pipe(finalize(() => this.spinner.hide()))
      .subscribe((res) => {
        this.onSubmit.emit(res);
        this.form.reset();
      });
  }
  editCard(formPayload: any) {
    this.spinner.show();
    this.service
      .UpdateCard({ paymentId: this.card?.paymentId, ...formPayload })
      .pipe(finalize(() => this.spinner.hide()))
      .subscribe((res) => {
        this.onSubmit.emit(res);
        this.form.reset();
      });
  }
  SubmitPayment() {
    this.submitted = true;
    if (this.form.invalid) {
      return;
    }

    if (this.mode === 'add') {
      this.addNewCard(this.form.value);
    } else {
      this.editCard(this.form.value);
    }
    console.log(this.form.value);
  }
}
