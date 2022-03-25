import { createApp } from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import store from './store'
import { BootstrapVue,IconsPlugin} from 'bootstrap-vue-3'
import 'bootstrap'
Vue.use(BootstrapVue)
Vue.use(IconsPlugin)

createApp(App).use(store).use(router).mount('#app')
