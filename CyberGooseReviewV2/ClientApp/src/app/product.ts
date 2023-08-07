import { Category } from "./category";
import { SubCategory } from "./sub-category";

export interface Product {
  Id: number;
  CategoryId: number;
  Category: Category;
  SubCategories: SubCategory[];
  Name: string;
  Description: string;
  YouTubeLink: string;
  UserRating: number;
  CriticRating: number;
  CommonRating: number;
  ProductPicture: any;
  Year: number;
  Country: string;
}
