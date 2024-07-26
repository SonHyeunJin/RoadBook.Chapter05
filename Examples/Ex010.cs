using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex010
    {
        public void Run()
        {
            // 기본 생성자 이용
            int number = 1;
            string title = "첫 번째 게시글입니다.";
            string contents = "첫 번째 공지사항입니다.";
            string writer = "운영자";

            Service.BoardService boardService = new Service.BoardService();
            boardService.Save(number, title, contents, writer);
            boardService.Read();

            Console.WriteLine("=====");

            // 게시글 수정
            title = "첫 번째 게시글 수정!!";
            boardService.Update(title, contents, writer);
            boardService.Read();

            Console.WriteLine("=====");

            // 게시글 삭제
            boardService.Delete();
            boardService.Read();

            Console.WriteLine("=====");

            // 생성자 오버로딩 이용
            Model.Board board = new Model.Board
            {
                Number = 2,
                Title = "두 번째 게시글입니다.",
                Contents = "두 번째 공지사항입니다.",
                Writer = "운영자",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            Service.BoardService anotherBoardService = new Service.BoardService(board);
            anotherBoardService.Read();
        }
    }
}
