
import axios from'axios'
export default new class ApiService {
    
    BASE_URL="https://localhost:7189";

    getListApi(){
        return axios.get(`${this.BASE_URL}/Client/GetClient`);
    }

}