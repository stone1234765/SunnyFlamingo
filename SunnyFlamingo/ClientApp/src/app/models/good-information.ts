import { Guid } from "guid-typescript";
import { PropertyListModel } from "./property-list-model";
import { PropertyModel } from "./property-model";

export interface GoodInformation{
  id: any;
  name: string;
  price: number;
  isAvailable: boolean;
  imgIds: Guid[];
  type: string;
  description: string;
  producer: string;
  country: string;
  material: string;
  color: string;
  properties: PropertyModel[];
  propertyLists: PropertyListModel[];
}
