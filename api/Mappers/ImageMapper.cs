using api.Dtos.Image;
using api.Models;

namespace api.Mappers
{
    public static class ImageMapper
    {
        public static ImageDto ToDto(this Image image)
        {
            var dto = new ImageDto
            {
                Id = image.Id,
                Url = image.Url,
                RoomId = image.RoomId,
            };
            return dto;
        }
    }
}