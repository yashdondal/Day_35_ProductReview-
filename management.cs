using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void TopRecords(List<ProductReview> review)
        {
            var records = (from productreview in review
                           orderby productreview.Rating descending
                           select productreview).Take(3);
            foreach (var list in records)
            {
                Console.WriteLine("productid : " + list.ProductID + " userid: " + list.UserID + " rating: " + list.Rating + " review: " + list.Review + " islike: " + list.ISLike);

            }
        }
        public void SelectedRow(List<ProductReview> review)
        {
            var selected = (from selection in review
                            where (selection.ProductID == 1 && selection.Rating > 3) ||
                            (selection.ProductID == 4 && selection.Rating > 3) ||
                            (selection.ProductID == 9 && selection.Rating > 3)
                            select selection);

            foreach (var list in selected)
            {
                Console.WriteLine("productid : " + list.ProductID + " userid: " + list.UserID + " rating: " + list.Rating + " review: " + list.Review + " islike: " + list.ISLike);
            }
        }
        public void RetrivecountRecords(List<ProductReview> review)
        {
            var count = review.GroupBy(x => x.ProductID).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in count)
            {
                Console.WriteLine("productid : " + list.ProductId + "count" + list.Count);
            }
        }
    }
}