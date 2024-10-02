package com.mycompany.movietime;

import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;

public class MovieTime {

    public static void main(String[] args) {
        Queue<String> movies = new LinkedList<>();
        Queue<String> snacks = new LinkedList<>();
        Scanner input = new Scanner(System.in);
        
        for (int i = 0; i < 3; i++){
            System.out.print("Enter movie " + (i + 1) + " of 3: ");
            String movie = input.nextLine();
            movies.offer(movie);
        }
        
        for (int i = 0; i < 3; i++){
            System.out.print("Enter snack " + (i + 1) + " of 3: ");
            String snack = input.nextLine();
            snacks.offer(snack);
        }
        
        System.out.println("Movies to watch are: deque(" + movies + ")");
        System.out.println("Snacks available are: deque(" + snacks + ")");
        
        System.out.println("Press 'S' each time you finish a snack.");
        
        char finish;
        
        do {
            finish = input.next().charAt(0);
            if (Character.toUpperCase(finish) == 'S') {
                if (!snacks.isEmpty()) {
                    snacks.poll();
                } else {
                    System.out.println("No more snacks.");
                    break;
                }
            } else {
                System.out.println("Invalid input, try to press 'S' only.");
            }
            System.out.println("deque(" + snacks + ")");
        } while (true);
        
        input.close();
    }
}
