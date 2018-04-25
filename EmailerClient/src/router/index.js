import Vue from 'vue'
import Router from 'vue-router'
// import BootstrapVue from 'bootstrap-vue'
// import 'bootstrap/dist/css/bootstrap.min.css'
// import 'bootstrap-vue/dist/bootstrap-vue.css'
import Email from '@/components/Email'
import About from '@/components/About'

Vue.use(Router)
// Vue.use(BootstrapVue)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Email',
      component: Email
    },
    {
      path: '/About',
      name: 'About',
      component: About
    }
  ]
})
