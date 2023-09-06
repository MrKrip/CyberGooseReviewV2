import { UserData } from "./user-data";

export interface Review {
  userData: UserData;
  rating: number;
  details: string | null;
  likes: number;
  disLikes: number;
  creationDate: Date;
  productId: number;
  productName: string;
}
