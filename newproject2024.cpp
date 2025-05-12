#include <iostream>
#include <fstream>
#include <string>
#include <sstream> // For stringstream
#include <vector>
#include <algorithm>
#include <cstring>
using namespace std;

// Base class for bookings
class BookingBase 
{
public:
    virtual void DisplayBookingDetails() = 0;
    virtual void SaveBookingToFile() = 0;
};

// Domestic booking class
class DomBooking : public BookingBase {
private:
    static int domPnr;

public:
    int dPnr;
    std::string flightDom;
    std::string dateDom;
    std::string domDep;
    std::string domArr;
    std::string meal1;

    DomBooking() {
        dPnr = ++domPnr;
    }

    void travelDetailsDom(const std::string &date, const std::string &source, const std::string &destination, const std::string &flight) {
        dateDom = date;
        flightDom = flight;
        // Assigning dummy departure and arrival times based on the flight for demonstration
        if (flight == "Air India") {
            domDep = "08:00";
            domArr = "11:05";
        } else if (flight == "IndiGo") {
            domDep = "14:00";
            domArr = "17:05";
        } else if (flight == "SpiceJet") {
            domDep = "19:00";
            domArr = "22:05";
        }
    }

    void mealsDom(const std::string &meal) {
        meal1 = meal;
    }

    void DisplayBookingDetails() override {
        std::cout << "Domestic Booking Details\n"
                  << "PNR: " << dPnr << "\n"
                  << "Flight: " << flightDom << "\n"
                  << "Date: " << dateDom << "\n"
                  << "Departure: " << domDep << "\n"
                  << "Arrival: " << domArr << "\n"
                  << "Meal: " << meal1 << "\n";
    }

    void SaveBookingToFile() override {
        std::ofstream writer("dom_booking_data.txt", std::ios::app);
        writer << "PNR: " << dPnr << "\n"
               << "Flight: " << flightDom << "\n"
               << "Date: " << dateDom << "\n"
               << "Departure: " << domDep << "\n"
               << "Arrival: " << domArr << "\n"
               << "Meal: " << meal1 << "\n"
               << "-----\n";
    }
};

int DomBooking::domPnr = 100;

// International booking class
class IntBooking : public BookingBase {
private:
    static int intPnr;

public:
    int pnrInt;
    std::string flightInt;
    std::string dateInt;
    std::string intDep;
    std::string intArr;
    std::string meal2;
    std::string modeOfPayment;
    std::string cardNumber;
    std::string expiryDate;
    std::string cvv;

    IntBooking() {
        pnrInt = ++intPnr;
    }

    void travelDetailsInt(const std::string &date, const std::string &source, const std::string &destination, const std::string &flight) {
        dateInt = date;
        flightInt = flight;
        // Assigning dummy departure and arrival times based on the flight for demonstration
        if (flight == "Air India") {
            intDep = "08:00";
            intArr = "11:05";
        } else if (flight == "IndiGo") {
            intDep = "14:00";
            intArr = "17:05";
        } else if (flight == "SpiceJet") {
            intDep = "19:00";
            intArr = "22:05";
        }
    }

    void mealsInt(const std::string &meal) {
        meal2 = meal;
    }

    void paymentDetails(const std::string &mode, const std::string &card, const std::string &expiry, const std::string &cvvCode) {
        modeOfPayment = mode;
        cardNumber = card;
        expiryDate = expiry;
        cvv = cvvCode;
    }

    void DisplayBookingDetails() override {
        cout << "International Booking Details\n"
                  << "PNR: " << pnrInt << "\n"
                  << "Flight: " << flightInt << "\n"
                  << "Date: " << dateInt << "\n"
                  << "Departure: " << intDep << "\n"
                  << "Arrival: " << intArr << "\n"
                  << "Meal: " << meal2 << "\n"
                  << "Mode of Payment: " << modeOfPayment << "\n"
                  << "Card Number: " << cardNumber << "\n"
                  << "Expiry Date: " << expiryDate << "\n"
                  << "CVV: " << cvv << "\n";
    }

    void SaveBookingToFile() override {
        ofstream writer("int_booking_data.txt", ios::app);
        writer << "PNR: " << pnrInt << "\n"
               << "Flight: " << flightInt << "\n"
               << "Date: " << dateInt << "\n"
               << "Departure: " << intDep << "\n"
               << "Arrival: " << intArr << "\n"
               << "Meal: " << meal2 << "\n"
               << "Mode of Payment: " << modeOfPayment << "\n"
               << "Card Number: " << cardNumber << "\n"
               << "Expiry Date: " << expiryDate << "\n"
               << "CVV: " << cvv << "\n"
               << "-----\n";
    }
};

int IntBooking::intPnr = 200;

// Base class for person details
class Person {
public:
    std::string name;
    std::string email;
    std::string gender;
    std::string contactNo;

    virtual void DisplayDetails() {
        std::cout << "Person details\n"
                  << "Name: " << name << "\n"
                  << "Gender: " << gender << "\n"
                  << "Email ID: " << email << "\n"
                  << "Contact No.: " << contactNo << "\n";
    }

    virtual void SaveToFile() {
        std::ofstream writer("person_details.txt", std::ios::app);
        writer << "Name: " << name << "\n"
               << "Gender: " << gender << "\n"
               << "Email ID: " << email << "\n"
               << "Contact No.: " << contactNo << "\n\n";
    }
};

// Derived class for passenger details
class Passenger : public Person {
public:
    std::string passNo;

    void DisplayDetails() override {
        std::cout << "Passenger details\n"
                  << "Name: " << name << "\n"
                  << "Gender: " << gender << "\n"
                  << "Email ID: " << email
        << "\nContact No.: " << contactNo << "\n"
        << "Passport No.: " << passNo << "\n";
    }

    void SaveToFile() override {
        std::ofstream writer("passenger_details.txt", std::ios::app);
        writer << "Name: " << name << "\n"
               << "Gender: " << gender << "\n"
               << "Email ID: " << email << "\n"
               << "Contact No.: " << contactNo << "\n"
               << "Passport No.: " << passNo << "\n\n";
    }
};

// Function to check a flight with PNR
#include <iostream>
#include <fstream>
#include <string>

// Function to check a flight with PNR
void CheckFlight(int pnrToCheck) {
    std::ifstream domFile("dom_booking_data.txt");
    std::ifstream intFile("int_booking_data.txt");
    if (!domFile.is_open() || !intFile.is_open()) {
        std::cerr << "Error: Could not open file for reading.\n";
        return;
    }

    std::string line;
    bool foundInDom = false;
    bool foundInInt = false;

    // Check in domestic bookings
    while (std::getline(domFile, line)) {
        if (line.find("PNR: " +  std::to_string(pnrToCheck)) != std::string::npos) {
            foundInDom = true;
            std::cout << "Booking details for PNR " << pnrToCheck << " (Domestic):\n";
            std::cout << line << '\n'; // Print the line containing the PNR
            // Assuming each booking detail is stored in a single line
            while (std::getline(domFile, line) && line != "-----") {
                std::cout << line << '\n'; // Print all other details until the separator
            }
            break;
        }
    }

    // Check in international bookings if not found in domestic
    if (!foundInDom) {
        while (std::getline(intFile, line)) {
            if (line.find("PNR: " + std::to_string(pnrToCheck)) != std::string::npos) {
                foundInInt = true;
                std::cout << "Booking details for PNR " << pnrToCheck << " (International):\n";
                std::cout << line << '\n'; // Print the line containing the PNR
                // Assuming each booking detail is stored in a single line
                while (std::getline(intFile, line) && line != "-----") {
                    std::cout << line << '\n'; // Print all other details until the separator
                }
                break;
            }
        }
    }

    domFile.close();
    intFile.close();

    if (!foundInDom && !foundInInt) {
        std::cout << "Booking with PNR " << pnrToCheck << " not found.\n";
    }
}


// Function to cancel a flight with PNR
void CancelFlight(int pnrToCancel) {
    bool canceled = false; // Declare canceled variable outside the inner blocks

    // Cancel Domestic Booking
    {
        std::ifstream domFile("dom_booking_data.txt");
        if (!domFile.is_open()) {
            std::cerr << "Error: Could not open domestic booking file for reading.\n";
            return;
        }

        std::ofstream tempDomFile("temp_dom_booking_data.txt");
        if (!tempDomFile.is_open()) {
            std::cerr << "Error: Could not create temporary domestic booking file.\n";
            domFile.close();
            return;
        }

        std::string line;
        while (std::getline(domFile, line)) {
            if (line.find("PNR: " + std::to_string(pnrToCancel)) != std::string::npos) {
                canceled = true;
                std::cout << "Domestic booking with PNR " << pnrToCancel << " canceled.\n";
                // Skip the lines corresponding to the canceled booking
                while (std::getline(domFile, line) && line != "-----") {
                    // Do nothing, effectively skipping the lines
                }
            } else {
                tempDomFile << line << '\n';
            }
        }

        domFile.close();
        tempDomFile.close();

        if (std::rename("temp_dom_booking_data.txt", "dom_booking_data.txt") != 0) {
            std::cerr << "Error: Could not rename temporary domestic booking file.\n";
        }
    }

    // Cancel International Booking
    {
        std::ifstream intFile("int_booking_data.txt");
        if (!intFile.is_open()) {
            std::cerr << "Error: Could not open international booking file for reading.\n";
            return;
        }

        std::ofstream tempIntFile("temp_int_booking_data.txt");
        if (!tempIntFile.is_open()) {
            std::cerr << "Error: Could not create temporary international booking file.\n";
            intFile.close();
            return;
        }

        std::string line;
        while (std::getline(intFile, line)) {
            if (line.find("PNR: " + std::to_string(pnrToCancel)) != std::string::npos) {
                canceled = true;
                std::cout << "International booking with PNR " << pnrToCancel << " canceled.\n";
                // Skip the lines corresponding to the canceled booking
                while (std::getline(intFile, line) && line != "-----") {
                    // Do nothing, effectively skipping the lines
                }
            } else {
                tempIntFile << line << '\n';
            }
        }

        intFile.close();
        tempIntFile.close();

        if (std::rename("temp_int_booking_data.txt", "int_booking_data.txt") != 0) {
            std::cerr << "Error: Could not rename temporary international booking file.\n";
        }
    }

    if (!canceled) {
        std::cout << "Booking with PNR " << pnrToCancel << " not found.\n";
    }
}



void BookFlight() {
    int subChoice;
    std::cout << "\nChoose flight type:\n";
    std::cout << "1. Domestic\n";
    std::cout << "2. International\n";
    std::cout << "Enter your choice: ";
    std::cin >> subChoice;

    switch (subChoice) {
        case 1: {
            DomBooking domBooking;
            std::cout << "Enter details for domestic flight booking.\n";
            std::string date, source, destination, flight, meal;
            std::cout << "Date (DD/MM/YYYY): ";
            std::cin >> date;
            std::cout << "Source: ";
            std::cin >> source;
            std::cout << "Destination: ";
            std::cin >> destination;
            std::cout << "Flight (Air India/IndiGo/SpiceJet): ";
            std::cin >> flight;
            std::cout << "Meal preference: ";
            std::cin >> meal;
            domBooking.travelDetailsDom(date, source, destination, flight);
            domBooking.mealsDom(meal);
            domBooking.DisplayBookingDetails();
            domBooking.SaveBookingToFile();
            break;
        }
        case 2: {
            IntBooking intBooking;
            std::cout << "Enter details for international flight booking.\n";
            std::string date, source, destination, flight, meal, mode, card, expiry, cvv;
            std::cout << "Date (DD/MM/YYYY): ";
            std::cin >> date;
            std::cout << "Source: ";
            std::cin >> source;
            std::cout << "Destination: ";
            std::cin >> destination;
            std::cout << "Flight (Air India/IndiGo/SpiceJet): ";
            std::cin >> flight;
            std::cout << "Meal preference: ";
            std::cin >> meal;
            std::cout << "Mode of payment: ";
            std::cin >> mode;
            std::cout << "Card number: ";
            std::cin >> card;
            std::cout << "Expiry date (MM/YY): ";
            std::cin >> expiry;
            std::cout << "CVV: ";
            std::cin >> cvv;
            intBooking.travelDetailsInt(date, source, destination, flight);
            intBooking.mealsInt(meal);
            intBooking.paymentDetails(mode, card, expiry, cvv);
            intBooking.DisplayBookingDetails();
            intBooking.SaveBookingToFile();
            break;
        }
        default:
            std::cout << "Invalid choice! Please enter either 1 or 2.\n";
            break;
    }
}

int main() {
    int choice;
    do {
        std::cout << "\nMain Menu:\n";
        std::cout << "1. Book a flight\n";
        std::cout << "2. Cancel a flight\n";
        std::cout << "3. Check flight with PNR\n";
        std::cout << "4. Exit\n";
        std::cout << "Enter your choice: ";
        std::cin >> choice;

        switch (choice) {
            case 1:
                BookFlight();
                break;
            case 2: {
                int pnrToCancel;
                std::cout << "Enter the PNR of the booking you want to cancel: ";
                std::cin >> pnrToCancel;
                CancelFlight(pnrToCancel);
                break;
            }
            case 3: {
                int pnrToCheck;
                std::cout << "Enter the PNR of the booking you want to check: ";
                std::cin >> pnrToCheck;
                CheckFlight(pnrToCheck);
                break;
            }
            case 4:
                std::cout << "Exiting program...\n";
                break;
            default:
                std::cout << "Invalid choice! Please enter a number between 1 and 4.\n";
                break;
        }
    } while (choice != 4);

    return 0;
}


// Function to cancel a flight with PNR
void CancelFlight() {
    std::cout << "Enter the PNR of the booking you want to cancel: ";
    int pnr;
    std::cin >> pnr;

    // Here, you would implement the logic to cancel the booking with the given PNR
    // This could involve removing the booking with the given PNR from files or databases
    // For demonstration purposes, let's just display a message that the booking will be canceled
    std::cout << "Canceling booking with PNR " << pnr << "...\n";

    // You can then remove the booking details from the file or database
}

//void BookFlight() {
//    int subChoice;
//    std::cout << "\nChoose flight type:\n";
//    std::cout << "1. Domestic\n";
//    std::cout << "2. International\n";
//    std::cout << "Enter your choice: ";
//    std::cin >> subChoice;
//
//    switch (subChoice) {
//        case 1: {
//            DomBooking domBooking;
//            std::cout << "Enter details for domestic flight booking.\n";
//            std::string date, source, destination, flight, meal;
//            std::cout << "Date (DD/MM/YYYY): ";
//            std::cin >> date;
//            std::cout << "Source: ";
//            std::cin >> source;
//            std::cout << "Destination: ";
//            std::cin >> destination;
//            std::cout << "Flight (Air India/IndiGo/SpiceJet): ";
//            std::cin >> flight;
//            std::cout << "Meal preference: ";
//            std::cin >> meal;
//            domBooking.travelDetailsDom(date, source, destination, flight);
//            domBooking.mealsDom(meal);
//            domBooking.DisplayBookingDetails();
//            domBooking.SaveBookingToFile();
//            break;
//        }
//        case 2: {
//            IntBooking intBooking;
//            std::cout << "Enter details for international flight booking.\n";
//            std::string date, source, destination, flight, meal, mode, card, expiry, cvv;
//            std::cout << "Date (DD/MM/YYYY): ";
//            std::cin >> date;
//            std::cout << "Source: ";
//            std::cin >> source;
//            std::cout << "Destination: ";
//            std::cin >> destination;
//            std::cout << "Flight (Air India/IndiGo/SpiceJet): ";
//            std::cin >> flight;
//            std::cout << "Meal preference: ";
//            std::cin >> meal;
//            std::cout << "Mode of payment: ";
//            std::cin >> mode;
//            std::cout << "Card number: ";
//            std::cin >> card;
//            std::cout << "Expiry date (MM/YY): ";
//            std::cin >> expiry;
//            std::cout << "CVV: ";
//            std::cin >> cvv;
//            intBooking.travelDetailsInt(date, source, destination, flight);
//            intBooking.mealsInt(meal);
//            intBooking.paymentDetails(mode, card, expiry, cvv);
//            intBooking.DisplayBookingDetails();
//            intBooking.SaveBookingToFile();
//            break;
//        }
//        default:
//            std::cout << "Invalid choice! Please enter either 1 or 2.\n";
//            break;
//    }
//}

//int main() {
//    std::cout << "Welcome to the booking system!\n";
//
//    Passenger passenger;
//    std::cout << "\nEnter Passenger Details:\n";
//    std::cout << "Name: ";
//    std::cin >> passenger.name;
//    std::cout << "Gender: ";
//    std::cin >> passenger.gender;
//    std::cout << "Email ID: ";
//    std::cin >> passenger.email;
//    std::cout << "Contact No.: ";
//    std::cin >> passenger.contactNo;
//    std::cout << "Passport No.: ";
//    std::cin >> passenger.passNo;
//
//    int choice;
//    do {
//        std::cout << "\nMain Menu:\n";
//        std::cout << "1. Book a flight\n";
//        std::cout << "2. Cancel a flight\n";
//        std::cout << "3. Check flight with PNR\n";
//        std::cout << "4. Exit\n";
//        std::cout << "Enter your choice: ";
//        std::cin >> choice;
//
//        switch (choice) {
//            case 1:
//                BookFlight();
//                break;
//            case 2:
//                CancelFlight();
//                break;
//            case 3:
//                CheckFlight();
//                break;
//            case 4:
//                std::cout << "Exiting program...\n";
//                break;
//            default:
//                std::cout << "Invalid choice! Please enter a number between 1 and 4.\n";
//                break;
//        }
//    } while (choice != 4);
//
//    return 0;
//}
