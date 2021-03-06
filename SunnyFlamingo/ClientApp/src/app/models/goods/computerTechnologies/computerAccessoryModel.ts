import { ComputerTechnologyModel } from "../computerTechnologyModel";

export class ComputerAccessoryModel extends ComputerTechnologyModel{
  constructor(options: {
    name: string;
    price: number;
    isAvailable: string;
    description: string;
    producerId: string;
    manufacturerId: string;
    material: string;
    color: string;
    imageIds: string[];
  }){
    super(options);
  }
}