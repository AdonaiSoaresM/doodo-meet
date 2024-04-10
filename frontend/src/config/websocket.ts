import {
  HubConnectionBuilder,
  LogLevel,
  IHttpConnectionOptions,
  HttpTransportType,
  HubConnection
} from "@microsoft/signalr";
import { envs } from "./envs";

export class SignalR {
  public connection: HubConnection;

  private auth_token: string;

  private options: IHttpConnectionOptions = {
    accessTokenFactory: () => this.auth_token,
    withCredentials: true,
    transport: HttpTransportType.WebSockets,
    skipNegotiation: true,

  };

  configure() {
    this.connection = new HubConnectionBuilder()
      .withUrl(envs.VITE_BACKEND_HUB_URL, this.options)
      .configureLogging(LogLevel.Debug)
      .build();
  }

  async start() {
    await this.connection.start();
  }

  set_token(AUTH_TOKEN: string) {
    this.auth_token = `${AUTH_TOKEN}`;
  }

  sendMessage(userId: string, message: string) {
    this.connection.invoke("SendMessage", userId, message);
  }

  sendId(id: string) {
    this.connection.invoke("SendId", id);
  }
}
