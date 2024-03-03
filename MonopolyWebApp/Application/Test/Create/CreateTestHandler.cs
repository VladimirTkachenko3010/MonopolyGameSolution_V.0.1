using MediatR;
using MonopolyWebApp.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MonopolyWebApp.Application.Test.Create
{
    public class CreateTestHandler : IRequestHandler<CreateTestRequestDto, CreateTestResponseDto>
    {
        // тут все нужные подключаешь ьд и т.д.
        public async Task<CreateTestResponseDto> Handle(CreateTestRequestDto request, CancellationToken cancellationToken)
        {
            // пример по типу добавления в бд
            var card = new Card()
            {
                CardType = request.CardType,
                Action = request.Action,
                Price = request.Price
            };

            return new CreateTestResponseDto(card.CardId);
        }
    }
}
