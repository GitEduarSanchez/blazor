namespace Domain.Dto;

public record CategoryDto(string Name, IEnumerable<ApplicationDto> Applications);
