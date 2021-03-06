import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GoodsRoutingModule } from './goods-routing.module';
import { GoodListComponent } from './good-list/good-list.component';
import { FiltersModule } from './filters/filters.module';
import { GoodsMainComponent } from './goods-main/goods-main.component';
import { ComputerTechnologyListComponent } from './goods/computer-technology-list/computer-technology-list.component';
import { LaptopListComponent } from './goods/computerTechnologies/laptop-list/laptop-list.component';
import { FlashDriveListComponent } from './goods/computerTechnologies/flash-drive-list/flash-drive-list.component';
import { ComputerPartListComponent } from './goods/computerTechnologies/computer-part-list/computer-part-list.component';
import { ComputerListComponent } from './goods/computerTechnologies/computer-list/computer-list.component';
import { ComputerAccessoryListComponent } from './goods/computerTechnologies/computer-accessory-list/computer-accessory-list.component';
import { VideoCardListComponent } from './goods/computerTechnologies/computerParts/video-card-list/video-card-list.component';
import { CPUListComponent } from './goods/computerTechnologies/computerParts/cpu-list/cpu-list.component';
import { CoolerListComponent } from './goods/computerTechnologies/computerParts/cooler-list/cooler-list.component';
import { ComputerDriveListComponent } from './goods/computerTechnologies/computerParts/computer-drive-list/computer-drive-list.component';
import { MauseListComponent } from './goods/computerTechnologies/computerAccessories/mause-list/mause-list.component';
import { KeyboardListComponent } from './goods/computerTechnologies/computerAccessories/keyboard-list/keyboard-list.component';
import { HeadphonesListComponent } from './goods/computerTechnologies/computerAccessories/headphones-list/headphones-list.component';
import { GoodCellComponent } from './good-cell/good-cell.component';
import { LoaderComponent } from '../loader/loader/loader.component';
import { LoaderModule } from '../loader/loader.module';
import { GoodsMenuComponent } from './goods-menu/goods-menu.component';
import { PaginationComponent } from './pagination/pagination.component';
import { CatalogSettingsComponent } from './catalog-settings/catalog-settings.component';

@NgModule({
  declarations: [
    GoodListComponent,
    GoodsMainComponent,
    ComputerTechnologyListComponent,
    LaptopListComponent,
    FlashDriveListComponent,
    ComputerPartListComponent,
    ComputerListComponent,
    ComputerAccessoryListComponent,
    VideoCardListComponent,
    CPUListComponent,
    CoolerListComponent,
    ComputerDriveListComponent,
    MauseListComponent,
    KeyboardListComponent,
    HeadphonesListComponent,
    GoodCellComponent,
    GoodsMenuComponent,
    PaginationComponent,
    CatalogSettingsComponent],
  imports: [
    CommonModule,
    FiltersModule,
    GoodsRoutingModule,
    LoaderModule
  ]
})
export class GoodsModule { }
