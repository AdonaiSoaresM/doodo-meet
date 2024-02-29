import { axios_instance } from "@/config/axios";

async function post(){
    return await axios_instance.post("/user")
}

const UserService = {
    post
}

export default UserService;

