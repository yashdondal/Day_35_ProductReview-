namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Product Review management problem");
            List<ProductReview> Productreviewlist = new List<ProductReview>();
            Productreviewlist.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "good", ISLike = true });
            Productreviewlist.Add(new ProductReview() { ProductID = 2, UserID = 6, Rating = 6, Review = "good", ISLike = true });
            Productreviewlist.Add(new ProductReview() { ProductID = 4, UserID = 2, Rating = 4, Review = "nice", ISLike = true });
            Productreviewlist.Add(new ProductReview() { ProductID = 4, UserID = 4, Rating = 6, Review = "bad", ISLike = true });
            Productreviewlist.Add(new ProductReview() { ProductID = 9, UserID = 2, Rating = 1, Review = "bad", ISLike = true });
            Productreviewlist.Add(new ProductReview() { ProductID = 6, UserID = 7, Rating = 2, Review = "nice", ISLike = true });
            Productreviewlist.Add(new ProductReview() { ProductID = 7, UserID = 8, Rating = 9, Review = "bad", ISLike = true });
            Productreviewlist.Add(new ProductReview() { ProductID = 9, UserID = 4, Rating = 4, Review = "good", ISLike = true });


            //foreach (var list in Productreviewlist)
            //{
            //    Console.WriteLine("productid : " + list.ProductID + " userid: " + list.UserID + " rating: " + list.Rating + " review: " + list.Review + " islike: " + list.ISLike);
            //}
            Management manage = new Management();
            //manage.TopRecords(Productreviewlist);
            manage.SelectedRow(Productreviewlist);

        }
    }
}