import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { NavigationEnd, Router } from '@angular/router';
import { GoodCellModel } from '../../models/good-cell-model';
import { GoodSearcherService } from '../../services/good-searcher.service';

@Component({
  selector: 'app-goods-searcher',
  templateUrl: './goods-searcher.component.html',
  styleUrls: ['./goods-searcher.component.css']
})
export class GoodsSearcherComponent implements OnInit {

  goodForm = this.fb.group({
    namePart: []
  });
  goods: GoodCellModel[] = [];

  constructor(private service: GoodSearcherService, private fb: FormBuilder, private router: Router) { }
  ngOnInit(): void {
    this.router.events
      .subscribe((val) => {
        if (val instanceof NavigationEnd) {
          if (this.goods != undefined && this.goods.length !== 0) {
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            console.log(this.goods);
            console.log("okey");
            
            this.goods = [];
            this.goodForm.reset();
          }
        }
    });
    this.goodForm.valueChanges
    .subscribe(() => this.service.searchGoodByName(this.goodForm.get("namePart")?.value)
    .subscribe(goods => this.goods = goods));
  }


  onSubmit(): void{
    this.service.searchGoodsByName(this.goodForm.get("namePart")?.value);
  }

}
