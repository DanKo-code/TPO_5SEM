import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

class Port {
    private int currentContainers = 0;
    private int capacity = 100; // Вместимость порта

    public int getCurrentContainers() {
        return currentContainers;
    }

    //synchronized - не может быть вызван одновременно из 2 потоков
    public synchronized void loadContainers(int amount) {
        while (currentContainers + amount > capacity) {
            try {
                wait(); // Ожидаем, если порт переполнен
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
        }
        currentContainers += amount;
        System.out.println(Thread.currentThread().getName() + " загрузил " + amount + " контейнеров. В порту: " + currentContainers);
        notifyAll(); // Уведомляем другие потоки о доступности порта
    }

    public synchronized void unloadContainers(int amount) {
        while (currentContainers < amount) {
            try {
                wait(); // Ожидаем, если в порту недостаточно контейнеров
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
        }
        currentContainers -= amount;
        System.out.println(Thread.currentThread().getName() + " разгрузил " + amount + " контейнеров. В порту: " + currentContainers);
        notifyAll(); // Уведомляем другие потоки о доступности порта
    }
}
