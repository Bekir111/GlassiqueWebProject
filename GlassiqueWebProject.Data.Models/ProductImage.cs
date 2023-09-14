namespace GlassiqueWebProject.Data.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; } // Foreign key to the Product entity
        public byte[] ImageData { get; set; } = null!;
        public string ImageMimeType { get; set; } = null!;
    }

}