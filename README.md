# Lab 2 Mini Project

A simple C# Windows Forms desktop application for bicycle rental and mushroom identification.

## Application Features

### Login

- Username and password cannot be empty.
- The username must contain at least one letter.
- Usernames can contain letters and numbers.
- Symbols and spaces are not accepted.

### Choose Activity

After logging in, the user can choose:

- Bicycle Rental
- Mushroom Identifier
- Back to Login
- Close the application

### Bicycle Rental

The user enters:

- Starting hour from `0` to `23`
- Ending hour from `1` to `24`

The application calculates the total rental cost automatically.

Hourly rates:

- `0–1` through `6–7`: 500 RWF per hour
- `7–8` through `13–14`: 1,000 RWF per hour
- `14–15` through `18–19`: 1,500 RWF per hour
- `19–20` and `20–21`: 1,000 RWF per hour
- `21–22`, `22–23`, and `23–24`: 500 RWF per hour

The form also includes:

- Calculate button
- Total output field
- Back button
- Logout button

### Mushroom Identifier

The application asks simple Yes/No questions using MessageBox and displays the mushroom result.

The form includes:

- Start Guessing button
- Back button
- Logout button

## Navigation

- Login → Choose
- Choose → Bicycle Rental
- Choose → Mushroom Identifier
- Back → Previous menu
- Logout → Login
- Close → Exit application

## Technologies Used

- C#
- .NET 10
- Windows Forms
- Visual Studio
