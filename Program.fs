open System

// Tax calculation function
let calculateTax (salary: float) =
    if salary <= 49020.0 then salary * 0.15
    elif salary <= 98040.0 then 49020.0 * 0.15 + (salary - 49020.0) * 0.205
    elif salary <= 151978.0 then 49020.0 * 0.15 + (98040.0 - 49020.0) * 0.205 + (salary - 98040.0) * 0.26
    elif salary <= 216511.0 then 49020.0 * 0.15 + (98040.0 - 49020.0) * 0.205 + (151978.0 - 98040.0) * 0.26 + (salary - 151978.0) * 0.29
    else 49020.0 * 0.15 + (98040.0 - 49020.0) * 0.205 + (151978.0 - 98040.0) * 0.26 + (216511.0 - 151978.0) * 0.29 + (salary - 216511.0) * 0.33

// Mapping, Filtering through Lists

let mysal = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

// Filter high-income salaries
let highIncomeSalaries = List.filter (fun sal -> sal > 100000.0) mysal
printfn "High-income salaries: %A" highIncomeSalaries

// Calculate tax for all salaries
let taxes = List.map calculateTax mysal
printfn "Taxes for all salaries: %A" taxes

// Add $20,000 to salaries less than $49,020
let updatedSalaries = List.map (fun sal -> if sal < 49020.0 then sal + 20000.0 else sal) mysal
printfn "Updated salaries: %A" updatedSalaries

// Sum salaries between $50,000 and $100,000
let totalSalary = List.filter (fun sal -> sal >= 50000.0 && sal <= 100000.0) updatedSalaries |> List.sum
printfn "Total salary between $50,000 and $100,000: %f" totalSalary

// Tail Recursion

let rec sumMultiplesOf3 n =
    let rec sumMultiplesHelper i acc =
        if i > n then acc
        else sumMultiplesHelper (i + 3) (acc + i)
    sumMultiplesHelper 3 0

// Test the function
let result = sumMultiplesOf3 27
printfn "Sum of multiples of 3 up to 27: %d" result
