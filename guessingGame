#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;

int main() {

    cout << "*********************************" << endl;
    cout << "* Welcome to the Guessing Game! *" << endl;
    cout << "*********************************" << endl;

    cout << "Easy (E), Medium (M) or Hard (H)" << endl;
    cout << "Choose difficulty: ";
    
    char difficulty;
    cin >> difficulty;





    int numberOfAttempts;

    if (difficulty == 'E') {
        numberOfAttempts = 30;
    }

    else if (difficulty == 'M') {
        numberOfAttempts = 15;
    }

    else {
        numberOfAttempts = 5;
    }

    srand(time(0));
    const int SECRET_NUMBER = rand() % 100;

    bool correctAnswer = false;
    int attempts = 0;

    double score = 1000.0;

    for (attempts = 1; attempts <= numberOfAttempts; attempts++) {

        int guess;
        cout << "Your guess: ";
        cin >> guess;





        correctAnswer = guess == SECRET_NUMBER;
        bool biggerThan = guess > SECRET_NUMBER;

        double lostPoints = abs(guess - SECRET_NUMBER) / 2;

        score -= lostPoints;



        if (correctAnswer) {
            cout << "You guessed the correct number in " << attempts << " attempt(s)!" << endl;
            cout.precision(2);
            cout << fixed;
            cout << "Your score is: " << score << endl;
            return 0;
        }

        else if (biggerThan) {
            cout << "Your number is bigger than the secret number." << endl;
        }

        else {
            cout << "Your number is smaller than the secret number." << endl;

        }
    }

    cout << "You lost..." << endl;
    cout.precision(2);
    cout << fixed;
    cout << "Your score is: " << score << endl;

}
