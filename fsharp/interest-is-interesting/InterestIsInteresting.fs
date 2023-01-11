module InterestIsInteresting

let interestRate (balance: decimal) : single =
    if balance < 0m then
        3.213f
    else if balance >= 0m && balance < 1000m then
        0.5f
    else if balance >= 1000m && balance < 5000m then
        1.621f
    else
        2.475f

let interest (balance: decimal) : decimal =
    let percentage = (balance |> interestRate |> decimal) / 100m
    balance * percentage

let annualBalanceUpdate (balance: decimal) : decimal = 
   balance + (balance |> interest)

let amountToDonate (balance: decimal) (taxFreePercentage: float) : int =
    let percentage = (taxFreePercentage |> decimal) / 100m
    if balance > 0m
    then (balance * percentage * 2m) |> int
    else 0
