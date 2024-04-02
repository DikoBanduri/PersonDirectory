using PersonDirectory.DTO;

namespace PersonDirectory.Api.Contracts;

public record PersonResponse(
    int Id,
    string FirsName,
    String LastName,
    Gender Gender,
    DateTime BirthDate,
    string PIN,
    string Address);
