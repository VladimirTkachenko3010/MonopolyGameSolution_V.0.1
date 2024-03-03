using MediatR;

namespace MonopolyWebApp.Application.Test.Create
{
    public class CreateTestRequestDto : IRequest<CreateTestResponseDto>
    {
        public string CardType { get; set; }
        public int Price { get; set; }
        public string Action { get; set; }
    }
}
