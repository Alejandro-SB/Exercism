module CarsAssemble

let carsPerHour = 221
let minutes = 60.0

let successRate (speed: int): float =
    if speed = 0 then
        0
    else if speed > 0 && speed <= 4 then
        1
    else if speed >=5 && speed <= 8 then
        0.9
    else if speed = 9 then
        0.8
    else
        0.77

let productionRatePerHour (speed: int): float =
    let validItems = successRate speed
    validItems * (float (carsPerHour * speed))

let workingItemsPerMinute (speed: int): int =
    let itemsPerHour = productionRatePerHour speed
    let itemsPerMinute = itemsPerHour / minutes
    (int itemsPerMinute)
