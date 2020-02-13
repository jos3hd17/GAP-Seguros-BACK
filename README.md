# GAP-Seguros-BACK

.NET Api With Entity Framework!


The project was created by: Jose David Hernandez Diaz

Repository pattern structure Already defined, but as ORM, i used Entity Framework, and InMemoryDatabase from Entity Framework.

Request Urls:

- https://localhost:5001/api/policies [POST], 
Body:
{
	"Name": "Riesgo contra derrumbe",
	"Description": "derrumbe",
	"Coverage": {
		"MinRisk": 10,
		"CoveragePercent": 10,
		"CoverageName": "Parcial"
	},
	"StartUp": "2010-10-10",
	"StartUpCoverage": "2012-10-09",
	"Price": 200000,
	"Customer": {
		"ClientName": "Andres",
		"City": "Medellin",
		"RiskPercent": 10
	}
}

- https://localhost:5001/api/policies [GET]

- https://localhost:5001/api/customer [POST]
Body:
{
	"ClientName": "Jose",
	"City": "Medellin",
	"RiskPercent": 30
}

- https://localhost:5001/api/customer [GET]
