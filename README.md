# Solutionists Products

## Instructions to run:
- Open the Solution file using Visual Studio
- Go to `Solutionists.Products.Web` project and set it as startup project
- Go to the `ClientApp` folder in `Solutionists.Products.Web` project and run `npm install` to download all Angular modules required to build the Angular project
- Run the `Solutionists.Products.Web` project using Visual Studio

The Angular and .NET Core Web API will launch automatically.

To view the `Swagger UI`, please navigate to `<BASE_URL>/swagger`

## Endpoints
- `api/products` to get all products
- `api/products/{id}` to get product by ID



## Technical details of the project:
### API
`.NET Core 5.0`
### UI
`Angular v8`


## Key highlights:
### API
- Async methods
- Configured `logging` to record API requests and Errors
- Used `Dictionary<>` as data store to speed up product look up
- Using Microsofts default `Dependency Injection` for Services and Repos
- Created clean folder structure for Data, Business and UI layers (`Separation of Concerns`)
- Used `Guid` ids to hide the Database indexing strategy
- `Cached response` to serve content faster
- Using a `CDN` backed image URL instead of storing images locally (to replicate a real-world scenario)
- Added `xUnit Tests` to test the core service methods
- Used `Cors` for local testing and development
- Added custom exception `NotFoundException` to handle specific cases when product(s) are not found

### Angular UI
- Using `Vanilla Bootstrap` for UI components
- Separate `routing map` to keep main module file clean
- Used a `ngx-spinner` to show loading animations
- Used Services to handle the API calls (Separation of Concerns)