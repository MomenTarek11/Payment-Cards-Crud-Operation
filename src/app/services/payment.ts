import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environment/environment';

@Injectable({
  providedIn: 'root',
})
export class PaymentService {
  constructor(private http: HttpClient) {}
  addCard(data: any) {
    return this.http.post(`${environment.apiUrl}/PaymentDetail`, data);
  }
  UpdateCard(data: any) {
    return this.http.put(`${environment.apiUrl}/PaymentDetail/${data.paymentId}`, data);
  }
  getCards() {
    return this.http.get(`${environment.apiUrl}/PaymentDetail`);
  }
  deleteCard(id: any) {
    return this.http.delete(`${environment.apiUrl}/PaymentDetail/${id}`);
  }
}
