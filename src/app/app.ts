import { Component, OnInit, signal } from '@angular/core';
import { Payment } from './payment/payment';
import { PaymentService } from './services/payment';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { finalize } from 'rxjs';
// import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [Payment, NgxSpinnerModule],
  templateUrl: './app.html',
  styleUrl: './app.scss',
})
export class App implements OnInit {
  cards: any = signal([]);
  card: any = signal({});
  constructor(
    private service: PaymentService,
    private spinner: NgxSpinnerService,
  ) {}
  ngOnInit(): void {
    this.getCards();
  }
  getCardNumber(cardNumber: any) {
    return (
      cardNumber?.slice(0, 4) +
      ' ' +
      cardNumber?.slice(4, 8) +
      ' ' +
      cardNumber?.slice(8, 12) +
      ' ' +
      cardNumber?.slice(12, 16)
    );
  }
  getCardExpiryDate(expiryDate: any) {
    return expiryDate?.slice(0, 2) + '/' + expiryDate?.slice(2, 4);
  }
  getCards() {
    this.spinner.show();
    this.service
      .getCards()
      .pipe(finalize(() => this.spinner.hide()))
      .subscribe((res: any) => {
        this.cards.set(res);
      });
  }
  getNumber(card: any) {
    this.card.set(card);
  }
  deleteCard(id: any) {
    this.service.deleteCard(id).subscribe((res: any) => {
      this.getCards();
    });
  }
}
