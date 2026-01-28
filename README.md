### Dispensa Virtual (Virtual Pantry)

#### Stack:
- **Frontend:** Angular 17+ (focusing on RxJS, Standalone Components and Interceptors).
- **Backend:** .NET 8 Web API (focusing on Entity Framework Core, LINQ, Dependency Injection).
- **Database:** PostgreSQL (focusing on Migrations, Indexes, Views).

#### Minimum Viable Product:
The main idea is create an app focused on pantry management. The user will input all his groceries, with their respective expirations dates, where the item was purchased and it's price. The system will:
- Warn the user when a product is about to expire;
- Give insights about prices.


### Development
##### Running Postgres and pgAdmin:
```
docker compose up -d
```
pgAdmin's interface is at http://127.0.0.1:8080/

**Closing docker containers:**
```
docker compose down
```