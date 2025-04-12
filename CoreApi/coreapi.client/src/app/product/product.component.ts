import { Component } from '@angular/core';
import { ServiceService } from '../Service/service.service';

@Component({
  selector: 'app-product',
  standalone: false,
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {

  constructor(private serv: ServiceService) { }
  ngOnInit() {
    this.getAllProducts();
  }

  Product: any;
  getAllProducts() {
    this.serv.getAllProducts().subscribe((data) => {
      this.Product = data;
    });
  }


}
