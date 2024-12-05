using System.Collections.Concurrent;
using System.Timers;
using AirSales;
using Timer = System.Timers.Timer;

// Instantiate Your variables, create threads etc..

// This line prevents program from exiting prematurely
Console.ReadLine();
return;

void DepartureTimerOnElapsed(object? sender, ElapsedEventArgs e)
{
    // This event occurs when Departure timer interval elapses
}

void LockedWriteLine(string message)
{
    // This function prints to console under lock
}

void StartClientFactory()
{
    // This function instantiates clientCreationTimer and adds 2 functions to Elapsed event
    // 1. CreateNewClient(object? sender, ElapsedEventArgs e)
    // 2. ClientCreationTimerRearm(object? sender, ElapsedEventArgs e)

}

void CreateNewClient(object? sender, ElapsedEventArgs e)
{
    // This function creates new Client object and adds it to ConcurrentQueue
}

void ClientCreationTimerRearm(object? sender, ElapsedEventArgs e)
{
    // This functions rearms the Interval of clientCreationTimer to random value between 5 and 25 millis
}

void SellTickets(object? obj)
{
    // This is the function that Worker threads execute - obj=worker 
}

void EndOfSales(string reason)
{
    // This function stops clientCreationTimer
    // - sends cancellation signal to all workers (threads) via CancellationTokensource
    // - calculates total revenue from all workers and number of clients served
    // - prints message "SALES STOPPED : ALL FLIGHTS SOLD OUT" or "SALES STOPPED : DEPARTURE" depending on the reason
    // - prints message "Total revenue: {totalRevenue}, Clients served total: {clientsServed}"

}