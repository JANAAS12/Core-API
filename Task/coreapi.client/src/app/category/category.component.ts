import { Component } from '@angular/core';
import { ServiceService } from '../Service/service.service';

@Component({
  selector: 'app-category',
  standalone: false,
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {

  constructor(private serv:ServiceService) { }
  ngOnInit() {
    this.getAllCategorys();
  }

  category: any;
  getAllCategorys() {
    this.serv.getAllCategory().subscribe((data) => {
      this.category = data;
    });
  }

}
