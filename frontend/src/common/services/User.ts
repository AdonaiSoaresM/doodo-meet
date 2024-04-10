import { axios_instance } from "@/config/axios";
import { ListUserViewModel } from "./types";

async function invoke_user(){
    return await axios_instance.post("/user")
}

async function list(){
    const response = await axios_instance.get<ListUserViewModel[]>("/user");
    return response.data;
}

const UserService = {
    invoke_user,
    list
}

export default UserService;

