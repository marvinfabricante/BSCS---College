package com.mycompany.fruitbasket;
import java.util.Scanner;
import java.util.Stack;
public class FruitBasket {

    public static void main(String[] args) {
        Stack<String> basket = new Stack<>();
        Scanner s = new Scanner(System.in);
        System.out.println("Catch and eat any of these fruits: ('apple', 'orange', 'mango', 'guava')");
        System.out.print("How many fruits would you like to catch? ");
        int amount = s.nextInt();
        s.nextLine();

        for (int i = 0; i < amount; i++) {
            System.out.print("Fruit " + (i + 1) + " of " + amount + ": ");
            String choice = s.nextLine().toUpperCase();
            String fruit = "";

            switch (choice) {
                case "A":
                    fruit = "apple";
                    break;
                case "O":
                    fruit = "orange";
                    break;
                case "M":
                    fruit = "mango";
                    break;
                case "G":
                    fruit = "guava";
                    break;
                default:
                    System.out.println("Invalid choice. Please enter A, O, M, or G.");
                    i--;
                    continue;
            }

            basket.push(fruit);
        }

        System.out.println("Your basket has now: " + basket);
        System.out.println("Press 'e' to eat a fruit: ");
        while (!basket.isEmpty()) {
            String command = s.nextLine();
            if (command.equalsIgnoreCase("e")) {
                System.out.println("Fruit(s) in the basket: " + basket);
                basket.pop();
                if (basket.isEmpty()) {
                    System.out.println("No more fruits.");
                }
            } else {
                System.out.println("Invalid command. Press 'e' to eat a fruit.");
            }
        }
        s.close();
    }
}
