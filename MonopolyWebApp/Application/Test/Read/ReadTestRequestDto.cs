using MediatR;

namespace MonopolyWebApp.Application.Test.Read
{
    public class ReadTestRequestDto : IRequest<ReadTestResponseDto>
    {
        public int Id { get; set; }
        public ReadTestRequestDto(int id)
        {
            Id = id;
        }
    }
}
