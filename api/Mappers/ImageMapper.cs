using api.Dtos.Image;
using api.Models;

namespace api.Mappers
{
    public static class ImageMapper
    {
        public static ImageDto ToImageDto(this Image image)
        {
            var dto = new ImageDto
            {
                Id = image.Id,
                Filename = image.Filename,
                RoomId = image.RoomId,
            };
            return dto;
        }
    }
}