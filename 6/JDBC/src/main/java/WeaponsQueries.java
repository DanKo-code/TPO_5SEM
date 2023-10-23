import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class WeaponsQueries {
    private Connection connection;

    public WeaponsQueries() {
        connection = DatabaseConnection.getConnection();
    }

    public void closeConnection() {
        try {
            if (connection != null) {
                connection.close();
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    // Вывести марки заданного типа часов
    public void getWeaponByType(Integer weaponPrice) throws SQLException {
        System.out.println("Вывод типа оружия по цене "+weaponPrice+":");
        try {
            String sql = "SELECT type FROM Weapons WHERE price = ?";
            PreparedStatement statement = connection.prepareStatement(sql);
            statement.setString(1, String.valueOf(weaponPrice));

            ResultSet resultSet = statement.executeQuery();
            if (!resultSet.isBeforeFirst()) {
                System.out.println("No results found.");
            } else {
                while (resultSet.next()) {
                    String type = resultSet.getString("type");
                    System.out.println(type);
                }
            } }catch(SQLException e){
                e.printStackTrace();
            }
        }
    // Вывести информацию о механических часах с ценой не выше заданной
    public void getPistolsByPrice(int maxPrice) {
        System.out.println("Вывод оружия ценой <= "+maxPrice+":");

        try {
            String sql = "SELECT * FROM Weapons WHERE type = 'pistol' AND price <= ?";
            PreparedStatement statement = connection.prepareStatement(sql);
            statement.setInt(1, maxPrice);

            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                int id = resultSet.getInt("weapon_id"); // Corrected to "watch_id"
                int price = resultSet.getInt("price");
                String type = resultSet.getString("type");
                // Add output for other fields as needed
                System.out.println("ID: " + id + ", type: " + type+", цена: "+price);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }


}
