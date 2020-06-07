import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/core/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.productService.get().subscribe(result => {
      console.log(result);
    })
  }
}
