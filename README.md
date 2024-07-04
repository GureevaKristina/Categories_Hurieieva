# Category Attribute Application

## Requirements
- .NET 8.0 Core

## Setup
1. Clone the repository:
    ```sh
    git clone https://github.com/GureevaKristina/Categories_Hurieieva
    cd Categories_Hurieieva
    ```

2. Restore the packages:
    ```sh
    dotnet restore
    ```

3. Build the project:
    ```sh
    dotnet build
    ```

## Running the Application
1. Run the application:
    ```sh
    dotnet run
    ```

2. The application will be available at `http://localhost:5144`.

## Swagger UI
The application uses Swagger for API documentation. You can access it at `http://localhost:5144`.

## Endpoints
- **POST /api/category/process**
    - Accepts a JSON array of categories and subcategories.
    - Returns a JSON array of the most popular attributes for each subcategory.

### Example Request
```json
[
    {
        "categoryName": "TVs",
        "subCategories": [
            {
                "categoryId": 80,
                "categoryName": "TVs"
            },
            {
                "categoryId": 948,
                "categoryName": "All-Weather TVs"
            },
            {
                "categoryId": 37,
                "categoryName": "TV Accessories"
            }
        ]
    }
]
