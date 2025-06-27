using System.ComponentModel.DataAnnotations.Schema;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Base;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Entities;

/// <summary>
/// User entity
/// </summary>
[Table("user")]
public class User : BaseEntity<long>
{
    [Column("firstName")] public string? FirstName { get; set; }
    [Column("lastName")] public string? LastName { get; set; }
    [Column("maidenName")] public string? MaidenName { get; set; }
    [Column("age")] public long? Age { get; set; }
    [Column("gender")] public string? Gender { get; set; }
    [Column("email")] public string? Email { get; set; }
    [Column("phone")] public string? Phone { get; set; }
    [Column("username")] public string? Username { get; set; }
    [Column("password")] public string? Password { get; set; }
    [Column("birthDate")] public string? BirthDate { get; set; }
    [Column("image")] public Uri? Image { get; set; }
    [Column("bloodGroup")] public string? BloodGroup { get; set; }
    [Column("height")] public double? Height { get; set; }
    [Column("weight")] public double? Weight { get; set; }
    [Column("eyeColor")] public string? EyeColor { get; set; }
    [Column("hair.color")] public string? HairColor { get; set; }
    [Column("hair.type")] public string? HairType { get; set; }
    [Column("ip")] public string? Ip { get; set; }
    [Column("address.address")] public string? AddressAddress { get; set; }
    [Column("address.city")] public string? AddressCity { get; set; }
    [Column("address.state")] public string? AddressState { get; set; }
    [Column("address.stateCode")] public string? AddressStateCode { get; set; }
    [Column("address.postalCode")] public long? AddressPostalCode { get; set; }
    [Column("address.coordinates.lat")] public double? AddressCoordinatesLat { get; set; }
    [Column("address.coordinates.lng")] public double? AddressCoordinatesLng { get; set; }
    [Column("address.country")] public string? AddressCountry { get; set; }
    [Column("macAddress")] public string? MacAddress { get; set; }
    [Column("university")] public string? University { get; set; }
    [Column("bank.cardExpire")] public string? BankCardExpire { get; set; }
    [Column("bank.cardNumber")] public string? BankCardNumber { get; set; }
    [Column("bank.cardType")] public string? BankCardType { get; set; }
    [Column("bank.currency")] public string? BankCurrency { get; set; }
    [Column("bank.iban")] public string? BankIban { get; set; }
    [Column("company.department")] public string? CompanyDepartment { get; set; }
    [Column("company.name")] public string? CompanyName { get; set; }
    [Column("company.title")] public string? CompanyTitle { get; set; }
    [Column("company.address.address")] public string? CompanyAddressAddress { get; set; }
    [Column("company.address.city")] public string? CompanyAddressCity { get; set; }
    [Column("company.address.state")] public string? CompanyAddressState { get; set; }
    [Column("company.address.stateCode")] public string? CompanyAddressStateCode { get; set; }
    [Column("company.address.postalCode")] public long? CompanyAddressPostalCode { get; set; }

    [Column("company.address.coordinates.lat")]
    public double? CompanyAddressCoordinatesLat { get; set; }

    [Column("company.address.coordinates.lng")]
    public double? CompanyAddressCoordinatesLng { get; set; }

    [Column("company.address.country")] public string? CompanyAddressCountry { get; set; }
    [Column("ein")] public string? Ein { get; set; }
    [Column("ssn")] public string? Ssn { get; set; }
    [Column("userAgent")] public string? UserAgent { get; set; }
    [Column("crypto.coin")] public string? CryptoCoin { get; set; }
    [Column("crypto.wallet")] public string? CryptoWallet { get; set; }
    [Column("crypto.network")] public string? CryptoNetwork { get; set; }
    [Column("role")] public string? Role { get; set; }
}