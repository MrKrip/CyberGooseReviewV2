import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ReviewService {

  private url: string = 'https://localhost:7176/';

  constructor(private http: HttpClient) {
  }

  getReviewsToProd<T>(id: number) {
    return this.http.get<T[]>(this.url + 'reviews/' + id);
  }
}
