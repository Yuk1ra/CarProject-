#include "library.h"

#include <iostream>
#include <bits/stdc++.h>

using namespace std;

void printMatrix(int matrix[][Size], int size) { //введення матриці
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            cout << matrix[i][j] << ' ';
        }
        cout << endl;
    }
}

int finding_min(int arr[Size1][Size1], int dim){ //функція знаходить мінімум
    cout << "Entered matrix: " << endl;
    for (int i = 0; i < dim; i++) {
        for (int j = 0; j < dim; j++)
            cout << arr[i][j] << " ";
        cout << endl;
    }
    cout << endl;

    int min;
    int minarr[Size1][Size1];
    int i;
    int j;
    for (i = 0; i < dim; i++) {
        min = arr[i][0];
        for (j = 0; j < dim; j++) {
            if (arr[i][j] <= min) {
                min = arr[i][j];
            }
        }
        cout << "Mix number in row: " << i << ": " << min << endl;
        cout << "This number has indexes: " << endl;
        for (int l = 0; l < dim; l++){
            if(arr[i][l] == min){
                minarr[i][l] = arr[i][l];
                cout << "[" << i << "] [" << l << "]; " << endl;
            }
        }
    }
    return min;
}

void matrix_input(){ //введення матриці
    cout << "Enter matrix dimension:" << endl;
    cin >> dim;
    cout << "Enter matrix: " << endl;
    for (int i = 0; i < dim; i++) {
        for (int j = 0; j < dim; j++) {
            cin >> arr[i][j];
        }
    }
}

void matrix_random_input(){ //введення матриці рандомними значеннями
    cout << "Enter matrix dimension: " << endl;
    cin >> dim;
    for (int i = 0; i < dim; i++) {
        for (int j = 0; j < dim; j++) {
            arr[i][j] = rand() % 10;
        }
    }
}

void minimum() { //min number and it`s index
    matrix_input();
    finding_min(arr, dim);
}

void minRand() { //min number and it`s index(random input)
    matrix_random_input();
    finding_min(arr, dim);
}

int main() {
    srand((unsigned)time(NULL));
    int menu_mode;
    while (1) {
        cout << "Hello, choose the mode :"
                "\nTASK 1"
                "\n1.Find the max number in array and its indexes(HANDMADE array)."
                "\n2.Find the max number in array and its indexes(RANDOM array)."
                "\n9.Exit"<< endl;

        cin >> menu_mode;
        switch (menu_mode) {
            case 1:
                minimum();
                break;
            case 2:
                minRand();
                break;
            case 3:{
                exit(0);
            }
        }
    }
}
