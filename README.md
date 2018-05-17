# YavorYankovLTD
Tracking activities for Yavor Yankov Limited Company

1. Models

    1.1. Tracking model
    * Tracking model store all data for day journey and delivery of parcels.

    Properties:
    Id - PK
    Date (date of current day) - Date
    Route (how much is big route in percents) - Short
    Miles (how many miles travelled for this date) - Short
    StopsToDeliver (how much stops have for current date) - Short
    Work (Is working or not at current date) - Bool

2. Data connection

3. Console Client

    3. 1. Initialize database through main class.

    3. 2. Create menu with different options
        - Add journey
        - Calendar
        - ???
        - Exit