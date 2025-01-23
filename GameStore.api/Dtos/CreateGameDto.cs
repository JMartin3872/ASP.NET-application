namespace GameStore.api.Dtos;

//No id as the api will assign this
public record class CreateGameDto(
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
){}
