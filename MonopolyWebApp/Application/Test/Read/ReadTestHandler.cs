using MediatR;
using MonopolyWebApp.Application.Test.Create;
using MonopolyWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MonopolyWebApp.Application.Test.Read
{
    public class ReadTestHandler : IRequestHandler<ReadTestRequestDto, ReadTestResponseDto>
    {
        // для вызова другого метода подключаешь медиатор так
        private readonly IMediator _mediator;

        public ReadTestHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ReadTestResponseDto> Handle(ReadTestRequestDto request, CancellationToken cancellationToken)
        {
            var cards = new List<Card>();
            var card = cards.FirstOrDefault(c => c.CardId == request.Id);

            if (card == null)
            {
                // вызываешь метод так, всегда через request
                var newCard = await _mediator.Send(new CreateTestRequestDto()
                {
                    Action = "N/A",
                    Price = 10,
                    CardType = "Test"
                });

                card = cards.FirstOrDefault(c => c.CardId == newCard.Id);
            }

            return new ReadTestResponseDto(card);
        }
    }
}
