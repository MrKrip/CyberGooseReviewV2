import { SubCategory } from "./sub-category";

export interface Category {
  id: number;
  name: string;
  subCategories: SubCategory[];
  roles: string[];
}
