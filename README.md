# Simple Sales API (.NET)
This is a simple sales API service that allows you to post sales, retrieve sales, fetch sales by transaction ID, and generate daily sales reports.

High level architecture diagram - Simple Sales API Services

![Diagram of the API flow](images/diagram.png)

## Developer Guide :blue_book:

**To run this application, following environment variables are required.**

export ASPNETCORE_ENVIRONMENT=Development
export DB_CONNECTION_STRING="Server=dbserver;Database=devops_challenge;User Id=sa;Password=test1234Fm@;"

To Build & Run commands
=======================

docker-compose build
docker-compose up

Swagger url (local): http://localhost:5000/swagger/index.html


Available Workflows
-------------------

* Auto Version Bump     --> To bump a new in main branch.
* Code Analysis         --> To analyze the code.
* PR Quality Check      --> To check PR tile formats.
* Deploy to Development --> To deploy the solution in the development environments

To run these workflows, you need to set up the following environment secrets & variables according to each environment.

Secrets:

> * ASPNETCORE_ENVIRONMENT

> * DB_CONNECTION_STRING

> * ECR_URL

> * AWS_ACCESS_KEY_ID

> * AWS_SECRET_ACCESS_KEY

> * API_DEPLOYMENT_ACCESS_TOKEN

> * SONAR_CLOUD_TOKEN

Variables:

> * SALES_API_ENDPOINT