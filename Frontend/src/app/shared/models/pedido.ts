import { PedidoItem } from "./pedido-item";

export interface Pedido {
  id?: string;
  nome: string;
  email: string;
  telefone: string;
  itens: PedidoItem[];
}
