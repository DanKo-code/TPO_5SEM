import java.sql.SQLException;

public class Main {
    public static void main(String[] args) throws SQLException {
        WeaponsQueries weaponsQueries = new WeaponsQueries();

        // Вывести марки механических часов с ценой не выше 100.0
        weaponsQueries.getPistolsByPrice(100);

        weaponsQueries.getWeaponByType(100);

        // Закрыть соединение
        weaponsQueries.closeConnection();
    }
}
