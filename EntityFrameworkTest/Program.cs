using EntityFrameworkTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //データ追加
            //InsertBooks();

            //データ読み取り
            //ReadBooks();

            //書籍情報アップデート
            //UpdateBook();

            //書籍情報削除
            DeleteBook();
        }

        /// <summary>
        /// 書籍情報削除
        /// </summary>
        static void DeleteBook()
        {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.SingleOrDefault(x => x.Id == 1);
                //.SingleOrDefaultの場合、対象が存在しなければ規定値（？）が返る
                //検索対象が存在すればbookはnullではないので削除実行
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// 書籍情報アップデート
        /// </summary>
        static void UpdateBook()
        {
            using (var db = new BooksDbContext())
            {
                //.Singleにて唯一の一致するレコードを返す
                var book = db.Books.Single(x => x.Title == "沈まぬ太陽");
                //ありえない数字を入れる
                book.PublishedYear = 2333;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 書籍タイトル出力
        /// </summary>
        static void ReadBooks()
        {
            using (var db = new BooksDbContext())
            {
                List<Book> bookList = db.Books.ToList();
                foreach (var item in bookList)
                {
                    Console.WriteLine(item.Title);
                }
            }
        }

        /// <summary>
        /// データ追加
        /// </summary>
        static void InsertBooks()
        {
            //usingを使用しているのでブロックを抜けた時に
            //BooksDbContextオブジェクトは破棄される
            using (var db = new BooksDbContext())
            {
                //書籍データ生成
                var book1 = new Book
                {
                    //IDは自動生成の為、登録しない
                    Title = "マスカレード・ホテル",
                    PublishedYear = 2011,
                    Author = new Author
                    {
                        Birthday = new DateTime(1958, 2, 4),
                        Gender = "M",
                        Name = "東野圭吾"
                    }
                };
                //book1の追加
                db.Books.Add(book1);
                //書籍データ生成
                var book2 = new Book
                {
                    Title = "沈まぬ太陽",
                    //おそらく文庫本の発行年
                    PublishedYear = 2001,
                    Author = new Author
                    {
                        Birthday = new DateTime(1924, 1, 2),
                        Gender = "F",
                        Name = "山崎豊子"
                    }
                };
                //book2の追加
                db.Books.Add(book2);
                //DBの更新
                db.SaveChanges();
            }
        }
    }
}
