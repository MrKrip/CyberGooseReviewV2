import { Category } from "./category";
import { SubCategory } from "./sub-category";

export interface Product {
  id: number;
  categoryId: number;
  category: Category;
  subCategories: SubCategory[];
  name: string;
  description: string;
  youTubeLink: string | null;
  userRating: number;
  criticRating: number;
  commonRating: number;
  productPicture: any;
  year: number;
  country: string;
}
