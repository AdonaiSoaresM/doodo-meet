import {
  HubConnectionBuilder,
  LogLevel,
  IHttpConnectionOptions,
  HttpTransportType,
  HubConnection,
} from "@microsoft/signalr";
import { envs } from "./envs";

export class SignalR {
  private connection: HubConnection;

  private auth_token: string;

  private options: IHttpConnectionOptions = {
    accessTokenFactory: () => this.auth_token,
    transport: HttpTransportType.WebSockets,
  };

  configure() {
    this.connection = new HubConnectionBuilder()
      .withUrl(envs.VITE_BACKEND_HUB_URL, this.options)
      .configureLogging(LogLevel.Information)
      .build();
  }

  async start() {
    await this.connection.start();
    console.log("SignalR Connected.");
  }

  set_token(AUTH_TOKEN: string) {
    this.auth_token = `Bearer ${AUTH_TOKEN}`;
    console.log("SignalR Token Set.");
  }
}
