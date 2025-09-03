using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

namespace Top.MasonTech.NetCoreBaseAPI.Infrastructure.Persistence.Entities;

/// <summary>
/// User entity
/// </summary>
[Table("user")]
public class User : BaseEntity<long>
{
    [Column("firstName")][MaxLength(4000)] public string? FirstName { get; set; }
    [Column("lastName")][MaxLength(4000)] public string? LastName { get; set; }
    [Column("maidenName")][MaxLength(4000)] public string? MaidenName { get; set; }
    [Column("age")] public long? Age { get; set; }
    [Column("gender")][MaxLength(4000)] public string? Gender { get; set; }
    [Column("email")][MaxLength(4000)] public string? Email { get; set; }
    [Column("phone")][MaxLength(4000)] public string? Phone { get; set; }
    [Column("username")][MaxLength(4000)] public string? Username { get; set; }
    [Column("password")][MaxLength(4000)] public string? Password { get; set; }
    [Column("birthDate")][MaxLength(4000)] public string? BirthDate { get; set; }
    [Column("image")] public Uri? Image { get; set; }
    [Column("bloodGroup")][MaxLength(4000)] public string? BloodGroup { get; set; }
    [Column("height")] public double? Height { get; set; }
    [Column("weight")] public double? Weight { get; set; }
    [Column("eyeColor")][MaxLength(4000)] public string? EyeColor { get; set; }
    [Column("hair.color")][MaxLength(4000)] public string? HairColor { get; set; }
    [Column("hair.type")][MaxLength(4000)] public string? HairType { get; set; }
    [Column("ip")][MaxLength(4000)] public string? Ip { get; set; }
    [Column("address.address")][MaxLength(4000)] public string? AddressAddress { get; set; }
    [Column("address.city")][MaxLength(4000)] public string? AddressCity { get; set; }
    [Column("address.state")][MaxLength(4000)] public string? AddressState { get; set; }
    [Column("address.stateCode")][MaxLength(4000)] public string? AddressStateCode { get; set; }
    [Column("address.postalCode")] public long? AddressPostalCode { get; set; }
    [Column("address.coordinates.lat")] public double? AddressCoordinatesLat { get; set; }
    [Column("address.coordinates.lng")] public double? AddressCoordinatesLng { get; set; }
    [Column("address.country")][MaxLength(4000)] public string? AddressCountry { get; set; }
    [Column("macAddress")][MaxLength(4000)] public string? MacAddress { get; set; }
    [Column("university")][MaxLength(4000)] public string? University { get; set; }
    [Column("bank.cardExpire")][MaxLength(4000)] public string? BankCardExpire { get; set; }
    [Column("bank.cardNumber")][MaxLength(4000)] public string? BankCardNumber { get; set; }
    [Column("bank.cardType")][MaxLength(4000)] public string? BankCardType { get; set; }
    [Column("bank.currency")][MaxLength(4000)] public string? BankCurrency { get; set; }
    [Column("bank.iban")][MaxLength(4000)] public string? BankIban { get; set; }
    [Column("company.department")][MaxLength(4000)] public string? CompanyDepartment { get; set; }
    [Column("company.name")][MaxLength(4000)] public string? CompanyName { get; set; }
    [Column("company.title")][MaxLength(4000)] public string? CompanyTitle { get; set; }
    [Column("company.address.address")][MaxLength(4000)] public string? CompanyAddressAddress { get; set; }
    [Column("company.address.city")][MaxLength(4000)] public string? CompanyAddressCity { get; set; }
    [Column("company.address.state")][MaxLength(4000)] public string? CompanyAddressState { get; set; }
    [Column("company.address.stateCode")][MaxLength(4000)] public string? CompanyAddressStateCode { get; set; }
    [Column("company.address.postalCode")] public long? CompanyAddressPostalCode { get; set; }

    [Column("company.address.coordinates.lat")]
    public double? CompanyAddressCoordinatesLat { get; set; }

    [Column("company.address.coordinates.lng")]
    public double? CompanyAddressCoordinatesLng { get; set; }

    [Column("company.address.country")][MaxLength(4000)] public string? CompanyAddressCountry { get; set; }
    [Column("ein")][MaxLength(4000)] public string? Ein { get; set; }
    [Column("ssn")][MaxLength(4000)] public string? Ssn { get; set; }
    [Column("userAgent")][MaxLength(4000)] public string? UserAgent { get; set; }
    [Column("crypto.coin")][MaxLength(4000)] public string? CryptoCoin { get; set; }
    [Column("crypto.wallet")][MaxLength(4000)] public string? CryptoWallet { get; set; }
    [Column("crypto.network")][MaxLength(4000)] public string? CryptoNetwork { get; set; }
    [Column("role")][MaxLength(4000)] public string? Role { get; set; }
}