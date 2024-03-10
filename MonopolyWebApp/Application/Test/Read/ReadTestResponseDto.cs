using MonopolyWebApp.Models;

namespace MonopolyWebApp.Application.Test.Read
{
    public class ReadTestResponseDto
    {
        public Card Card { get; set; }
        public ReadTestResponseDto(Card card)
        {
            Card = card;
        }
    }
}
