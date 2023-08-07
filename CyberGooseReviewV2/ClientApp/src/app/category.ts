import { SubCategory } from "./sub-category";

export interface Category {
  Id: number;
  Name: string;
  subCategories: SubCategory[];
  Roles: string[];
}
