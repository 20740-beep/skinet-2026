using System.ComponentModel.DataAnnotations;
using Core.Entities;


namespace API.DTOs;

public class AddressDto
{
    [Required]
    public  string Line1 { get; set; } = string.Empty;

    public  string? Line2 { get; set; }

    [Required]
    public  string City { get; set; } = string.Empty;

    [Required]
    public  string State { get; set; } = string.Empty;

    [Required]
    public  string PostalCode { get; set; } = string.Empty;

    [Required]
    public  string Country { get; set; } = string.Empty;

    public Address toEntity()
    {   
        return new Address
        {
            Line1 = Line1,
            Line2 = Line2,
            City = City,
            State = State,
            Country = Country,
            PostalCode = PostalCode
        };
    }
}
