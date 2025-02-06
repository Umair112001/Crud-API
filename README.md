# StudentAPI

StudentAPI is a simple ASP.NET Core Web API for managing student records.

## Features
- Retrieve all students
- Retrieve a specific student by ID
- Add a new student
- Update an existing student
- Delete a student

## Technologies Used
- ASP.NET Core
- C#

## Endpoints

### Get all students
- GET /api/student
Returns a list of all students.

### Get a student by ID
Returns the student with the specified ID.

### Add a new student
**Body (JSON):**
json
{
  "id": 1,
  "name": "John Doe",
  "age": 20
}

### Update a student
json
{
  "id": 1,
  "name": "Jane Doe",
  "age": 21
}

### DELETE /api/student/{id}
