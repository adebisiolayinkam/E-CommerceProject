import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IPagination } from './shared/models/pagination';
import { IProduct } from './shared/models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'E-COMMERCE';
 
  // products: IProduct[];
 

  constructor() { }
   //  constructor(private http: HttpClient) { }
  ngOnInit(): void {

  //   this.http.get('https://localhost:5001/api/products?pageSize=50').subscribe(
  //     (response: IPagination) => {
    
  // // this.http.get('https://jsonplaceholder.typicode.com/users').subscribe((response: any) => {
  //    this.products = response.data;
  //   }, error => {
  //       console.log(error);
  //   });

  }
}